using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Cottunculus;

/// <summary>
/// Abstract class for Cottunculus (genus).
/// NCBI TaxId: 241829
/// </summary>
public abstract class Cottunculus : Psychrolutidae, ICottunculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottunculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241829;

    /// <inheritdoc />
    public virtual string GenusName => "Cottunculus";

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
