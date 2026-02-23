using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Archidistoma;

/// <summary>
/// Abstract class for Archidistoma (genus).
/// NCBI TaxId: 286145
/// </summary>
public abstract class Archidistoma : Polycitoridae, IArchidistoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archidistoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286145;

    /// <inheritdoc />
    public virtual string GenusName => "Archidistoma";

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
