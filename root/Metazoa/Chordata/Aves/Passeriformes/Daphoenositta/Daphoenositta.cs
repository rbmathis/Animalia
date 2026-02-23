using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Daphoenositta;

/// <summary>
/// Abstract class for Daphoenositta (genus).
/// NCBI TaxId: 254527
/// </summary>
public abstract class Daphoenositta : Passeriformes, IDaphoenositta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daphoenositta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254527;

    /// <inheritdoc />
    public virtual string GenusName => "Daphoenositta";

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
