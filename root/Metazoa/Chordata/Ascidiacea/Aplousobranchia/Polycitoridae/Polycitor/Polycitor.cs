using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Polycitor;

/// <summary>
/// Abstract class for Polycitor (genus).
/// NCBI TaxId: 286202
/// </summary>
public abstract class Polycitor : Polycitoridae, IPolycitor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polycitor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286202;

    /// <inheritdoc />
    public virtual string GenusName => "Polycitor";

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
