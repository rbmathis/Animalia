using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Junco;

/// <summary>
/// Abstract class for Junco (genus).
/// NCBI TaxId: 40213
/// </summary>
public abstract class Junco : Passerellidae, IJunco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Junco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40213;

    /// <inheritdoc />
    public virtual string GenusName => "Junco";

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
