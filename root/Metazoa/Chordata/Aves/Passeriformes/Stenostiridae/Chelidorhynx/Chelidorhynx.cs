using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Chelidorhynx;

/// <summary>
/// Abstract class for Chelidorhynx (genus).
/// NCBI TaxId: 1763892
/// </summary>
public abstract class Chelidorhynx : Stenostiridae, IChelidorhynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelidorhynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1763892;

    /// <inheritdoc />
    public virtual string GenusName => "Chelidorhynx";

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
