using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Cystodytes;

/// <summary>
/// Abstract class for Cystodytes (genus).
/// NCBI TaxId: 260823
/// </summary>
public abstract class Cystodytes : Polycitoridae, ICystodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cystodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260823;

    /// <inheritdoc />
    public virtual string GenusName => "Cystodytes";

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
