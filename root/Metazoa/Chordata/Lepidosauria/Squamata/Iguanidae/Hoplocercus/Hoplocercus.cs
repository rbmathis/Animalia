using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Hoplocercus;

/// <summary>
/// Abstract class for Hoplocercus (genus).
/// NCBI TaxId: 52192
/// </summary>
public abstract class Hoplocercus : Iguanidae, IHoplocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52192;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplocercus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
