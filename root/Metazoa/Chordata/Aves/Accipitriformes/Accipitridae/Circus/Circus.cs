using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Circus;

/// <summary>
/// Abstract class for Circus (genus).
/// NCBI TaxId: 8963
/// </summary>
public abstract class Circus : Accipitridae, ICircus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Circus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8963;

    /// <inheritdoc />
    public virtual string GenusName => "Circus";

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
