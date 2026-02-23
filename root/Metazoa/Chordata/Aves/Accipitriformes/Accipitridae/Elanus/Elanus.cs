using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Elanus;

/// <summary>
/// Abstract class for Elanus (genus).
/// NCBI TaxId: 321062
/// </summary>
public abstract class Elanus : Accipitridae, IElanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321062;

    /// <inheritdoc />
    public virtual string GenusName => "Elanus";

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
