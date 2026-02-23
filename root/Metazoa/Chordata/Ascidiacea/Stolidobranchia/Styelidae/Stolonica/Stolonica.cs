using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Stolonica;

/// <summary>
/// Abstract class for Stolonica (genus).
/// NCBI TaxId: 581073
/// </summary>
public abstract class Stolonica : Styelidae, IStolonica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stolonica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581073;

    /// <inheritdoc />
    public virtual string GenusName => "Stolonica";

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
