using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Cymbilaimus;

/// <summary>
/// Abstract class for Cymbilaimus (genus).
/// NCBI TaxId: 419693
/// </summary>
public abstract class Cymbilaimus : Thamnophilidae, ICymbilaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymbilaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419693;

    /// <inheritdoc />
    public virtual string GenusName => "Cymbilaimus";

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
