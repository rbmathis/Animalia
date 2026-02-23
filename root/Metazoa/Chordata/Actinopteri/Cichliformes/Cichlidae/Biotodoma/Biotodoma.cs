using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Biotodoma;

/// <summary>
/// Abstract class for Biotodoma (genus).
/// NCBI TaxId: 81346
/// </summary>
public abstract class Biotodoma : Cichlidae, IBiotodoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Biotodoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81346;

    /// <inheritdoc />
    public virtual string GenusName => "Biotodoma";

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
