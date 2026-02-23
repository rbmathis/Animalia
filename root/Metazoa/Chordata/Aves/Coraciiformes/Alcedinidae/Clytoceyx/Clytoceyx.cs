using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Clytoceyx;

/// <summary>
/// Abstract class for Clytoceyx (genus).
/// NCBI TaxId: 342393
/// </summary>
public abstract class Clytoceyx : Alcedinidae, IClytoceyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clytoceyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342393;

    /// <inheritdoc />
    public virtual string GenusName => "Clytoceyx";

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
