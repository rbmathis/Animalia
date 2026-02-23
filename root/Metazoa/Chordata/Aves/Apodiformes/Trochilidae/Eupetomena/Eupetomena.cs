using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eupetomena;

/// <summary>
/// Abstract class for Eupetomena (genus).
/// NCBI TaxId: 153632
/// </summary>
public abstract class Eupetomena : Trochilidae, IEupetomena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupetomena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153632;

    /// <inheritdoc />
    public virtual string GenusName => "Eupetomena";

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
