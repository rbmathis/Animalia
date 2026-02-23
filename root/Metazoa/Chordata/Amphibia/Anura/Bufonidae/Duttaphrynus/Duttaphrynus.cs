using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Duttaphrynus;

/// <summary>
/// Abstract class for Duttaphrynus (genus).
/// NCBI TaxId: 651680
/// </summary>
public abstract class Duttaphrynus : Bufonidae, IDuttaphrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Duttaphrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651680;

    /// <inheritdoc />
    public virtual string GenusName => "Duttaphrynus";

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
