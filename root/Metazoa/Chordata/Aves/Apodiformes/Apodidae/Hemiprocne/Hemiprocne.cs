using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hemiprocne;

/// <summary>
/// Abstract class for Hemiprocne (genus).
/// NCBI TaxId: 46509
/// </summary>
public abstract class Hemiprocne : Apodidae, IHemiprocne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiprocne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46509;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiprocne";

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
