using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Erythrocercus;

/// <summary>
/// Abstract class for Erythrocercus (genus).
/// NCBI TaxId: 107207
/// </summary>
public abstract class Erythrocercus : Dicruridae, IErythrocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107207;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrocercus";

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
