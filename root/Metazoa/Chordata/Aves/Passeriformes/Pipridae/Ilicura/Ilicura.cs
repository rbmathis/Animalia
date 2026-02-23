using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Ilicura;

/// <summary>
/// Abstract class for Ilicura (genus).
/// NCBI TaxId: 208055
/// </summary>
public abstract class Ilicura : Pipridae, IIlicura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ilicura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208055;

    /// <inheritdoc />
    public virtual string GenusName => "Ilicura";

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
