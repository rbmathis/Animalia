using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Auchenionchus;

/// <summary>
/// Abstract class for Auchenionchus (genus).
/// NCBI TaxId: 57781
/// </summary>
public abstract class Auchenionchus : Labrisomidae, IAuchenionchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auchenionchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57781;

    /// <inheritdoc />
    public virtual string GenusName => "Auchenionchus";

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
