using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Chasmistes;

/// <summary>
/// Abstract class for Chasmistes (genus).
/// NCBI TaxId: 156984
/// </summary>
public abstract class Chasmistes : Catostomidae, IChasmistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chasmistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156984;

    /// <inheritdoc />
    public virtual string GenusName => "Chasmistes";

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
