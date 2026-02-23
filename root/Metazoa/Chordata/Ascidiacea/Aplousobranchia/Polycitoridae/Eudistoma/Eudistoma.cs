using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Eudistoma;

/// <summary>
/// Abstract class for Eudistoma (genus).
/// NCBI TaxId: 286195
/// </summary>
public abstract class Eudistoma : Polycitoridae, IEudistoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudistoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286195;

    /// <inheritdoc />
    public virtual string GenusName => "Eudistoma";

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
