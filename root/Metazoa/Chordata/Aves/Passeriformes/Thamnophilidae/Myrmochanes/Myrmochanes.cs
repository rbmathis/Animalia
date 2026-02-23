using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmochanes;

/// <summary>
/// Abstract class for Myrmochanes (genus).
/// NCBI TaxId: 288093
/// </summary>
public abstract class Myrmochanes : Thamnophilidae, IMyrmochanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmochanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288093;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmochanes";

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
