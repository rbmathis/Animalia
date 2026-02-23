using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Urosticte;

/// <summary>
/// Abstract class for Urosticte (genus).
/// NCBI TaxId: 304691
/// </summary>
public abstract class Urosticte : Trochilidae, IUrosticte
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urosticte";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304691;

    /// <inheritdoc />
    public virtual string GenusName => "Urosticte";

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
