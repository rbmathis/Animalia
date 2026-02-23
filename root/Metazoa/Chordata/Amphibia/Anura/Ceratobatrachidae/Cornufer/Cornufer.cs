using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Cornufer;

/// <summary>
/// Abstract class for Cornufer (genus).
/// NCBI TaxId: 685121
/// </summary>
public abstract class Cornufer : Ceratobatrachidae, ICornufer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cornufer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685121;

    /// <inheritdoc />
    public virtual string GenusName => "Cornufer";

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
