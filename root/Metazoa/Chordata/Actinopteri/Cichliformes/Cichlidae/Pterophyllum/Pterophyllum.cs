using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pterophyllum;

/// <summary>
/// Abstract class for Pterophyllum (genus).
/// NCBI TaxId: 74130
/// </summary>
public abstract class Pterophyllum : Cichlidae, IPterophyllum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterophyllum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74130;

    /// <inheritdoc />
    public virtual string GenusName => "Pterophyllum";

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
