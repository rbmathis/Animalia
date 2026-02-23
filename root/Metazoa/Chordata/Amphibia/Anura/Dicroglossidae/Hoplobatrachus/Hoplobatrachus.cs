using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus;

/// <summary>
/// Abstract class for Hoplobatrachus (genus).
/// NCBI TaxId: 110071
/// </summary>
public abstract class Hoplobatrachus : Dicroglossidae, IHoplobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110071;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplobatrachus";

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
