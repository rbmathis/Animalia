using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Curaeus;

/// <summary>
/// Abstract class for Curaeus (genus).
/// NCBI TaxId: 84794
/// </summary>
public abstract class Curaeus : Icteridae, ICuraeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Curaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84794;

    /// <inheritdoc />
    public virtual string GenusName => "Curaeus";

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
