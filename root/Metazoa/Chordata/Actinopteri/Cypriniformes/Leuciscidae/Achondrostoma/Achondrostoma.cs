using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Achondrostoma;

/// <summary>
/// Abstract class for Achondrostoma (genus).
/// NCBI TaxId: 437164
/// </summary>
public abstract class Achondrostoma : Leuciscidae, IAchondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 437164;

    /// <inheritdoc />
    public virtual string GenusName => "Achondrostoma";

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
