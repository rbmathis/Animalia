using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Xenopipo;

/// <summary>
/// Abstract class for Xenopipo (genus).
/// NCBI TaxId: 114389
/// </summary>
public abstract class Xenopipo : Pipridae, IXenopipo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopipo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114389;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopipo";

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
