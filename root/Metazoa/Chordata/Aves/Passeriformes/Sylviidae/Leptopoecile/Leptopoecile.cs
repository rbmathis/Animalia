using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Leptopoecile;

/// <summary>
/// Abstract class for Leptopoecile (genus).
/// NCBI TaxId: 73331
/// </summary>
public abstract class Leptopoecile : Sylviidae, ILeptopoecile
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptopoecile";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73331;

    /// <inheritdoc />
    public virtual string GenusName => "Leptopoecile";

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
