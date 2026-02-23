using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Rastrinus;

/// <summary>
/// Abstract class for Rastrinus (genus).
/// NCBI TaxId: 1311558
/// </summary>
public abstract class Rastrinus : Cottidae, IRastrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rastrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311558;

    /// <inheritdoc />
    public virtual string GenusName => "Rastrinus";

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
