using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Helicolestes;

/// <summary>
/// Abstract class for Helicolestes (genus).
/// NCBI TaxId: 2869451
/// </summary>
public abstract class Helicolestes : Accipitridae, IHelicolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helicolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2869451;

    /// <inheritdoc />
    public virtual string GenusName => "Helicolestes";

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
