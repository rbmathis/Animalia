using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Boulengerochromis;

/// <summary>
/// Abstract class for Boulengerochromis (genus).
/// NCBI TaxId: 32487
/// </summary>
public abstract class Boulengerochromis : Cichlidae, IBoulengerochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulengerochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32487;

    /// <inheritdoc />
    public virtual string GenusName => "Boulengerochromis";

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
