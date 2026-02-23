using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Ciliata;

/// <summary>
/// Abstract class for Ciliata (genus).
/// NCBI TaxId: 210569
/// </summary>
public abstract class Ciliata : Lotidae, ICiliata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ciliata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210569;

    /// <inheritdoc />
    public virtual string GenusName => "Ciliata";

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
