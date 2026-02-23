using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Conolophus;

/// <summary>
/// Abstract class for Conolophus (genus).
/// NCBI TaxId: 31139
/// </summary>
public abstract class Conolophus : Iguanidae, IConolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 31139;

    /// <inheritdoc />
    public virtual string GenusName => "Conolophus";

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
