using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Pyroderus;

/// <summary>
/// Abstract class for Pyroderus (genus).
/// NCBI TaxId: 114374
/// </summary>
public abstract class Pyroderus : Cotingidae, IPyroderus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyroderus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114374;

    /// <inheritdoc />
    public virtual string GenusName => "Pyroderus";

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
