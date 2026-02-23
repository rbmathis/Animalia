using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Aplidium;

/// <summary>
/// Abstract class for Aplidium (genus).
/// NCBI TaxId: 201956
/// </summary>
public abstract class Aplidium : Polyclinidae, IAplidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201956;

    /// <inheritdoc />
    public virtual string GenusName => "Aplidium";

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
