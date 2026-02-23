using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Lepidobatrachus;

/// <summary>
/// Abstract class for Lepidobatrachus (genus).
/// NCBI TaxId: 8375
/// </summary>
public abstract class Lepidobatrachus : Ceratophryidae, ILepidobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8375;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidobatrachus";

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
