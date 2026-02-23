using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Parabuteo;

/// <summary>
/// Abstract class for Parabuteo (genus).
/// NCBI TaxId: 223491
/// </summary>
public abstract class Parabuteo : Accipitridae, IParabuteo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabuteo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223491;

    /// <inheritdoc />
    public virtual string GenusName => "Parabuteo";

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
