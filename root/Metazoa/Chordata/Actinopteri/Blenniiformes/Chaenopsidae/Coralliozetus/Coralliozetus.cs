using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Coralliozetus;

/// <summary>
/// Abstract class for Coralliozetus (genus).
/// NCBI TaxId: 346250
/// </summary>
public abstract class Coralliozetus : Chaenopsidae, ICoralliozetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coralliozetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 346250;

    /// <inheritdoc />
    public virtual string GenusName => "Coralliozetus";

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
