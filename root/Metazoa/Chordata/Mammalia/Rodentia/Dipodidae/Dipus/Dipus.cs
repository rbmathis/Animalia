using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Dipus;

/// <summary>
/// Abstract class for Dipus (genus).
/// NCBI TaxId: 73862
/// </summary>
public abstract class Dipus : Dipodidae, IDipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73862;

    /// <inheritdoc />
    public virtual string GenusName => "Dipus";

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
