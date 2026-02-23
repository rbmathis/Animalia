using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Parvimolge;

/// <summary>
/// Abstract class for Parvimolge (genus).
/// NCBI TaxId: 187953
/// </summary>
public abstract class Parvimolge : Plethodontidae, IParvimolge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvimolge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187953;

    /// <inheritdoc />
    public virtual string GenusName => "Parvimolge";

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
