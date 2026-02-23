using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapognathus;

/// <summary>
/// Abstract class for Elapognathus (genus).
/// NCBI TaxId: 529693
/// </summary>
public abstract class Elapognathus : Elapidae, IElapognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elapognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529693;

    /// <inheritdoc />
    public virtual string GenusName => "Elapognathus";

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
