using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Machaerirhynchus;

/// <summary>
/// Abstract class for Machaerirhynchus (genus).
/// NCBI TaxId: 338558
/// </summary>
public abstract class Machaerirhynchus : Dicruridae, IMachaerirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Machaerirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338558;

    /// <inheritdoc />
    public virtual string GenusName => "Machaerirhynchus";

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
