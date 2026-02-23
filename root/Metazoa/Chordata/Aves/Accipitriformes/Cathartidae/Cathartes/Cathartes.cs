using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Cathartes;

/// <summary>
/// Abstract class for Cathartes (genus).
/// NCBI TaxId: 33611
/// </summary>
public abstract class Cathartes : Cathartidae, ICathartes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cathartes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33611;

    /// <inheritdoc />
    public virtual string GenusName => "Cathartes";

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
