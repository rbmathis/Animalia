using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Nephtheis;

/// <summary>
/// Abstract class for Nephtheis (genus).
/// NCBI TaxId: 439810
/// </summary>
public abstract class Nephtheis : Polycitoridae, INephtheis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nephtheis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 439810;

    /// <inheritdoc />
    public virtual string GenusName => "Nephtheis";

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
