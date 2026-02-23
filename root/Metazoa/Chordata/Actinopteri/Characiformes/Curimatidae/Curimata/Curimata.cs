using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimata;

/// <summary>
/// Abstract class for Curimata (genus).
/// NCBI TaxId: 143033
/// </summary>
public abstract class Curimata : Curimatidae, ICurimata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Curimata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143033;

    /// <inheritdoc />
    public virtual string GenusName => "Curimata";

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
