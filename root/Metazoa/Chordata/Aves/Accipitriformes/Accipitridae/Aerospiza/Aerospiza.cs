using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aerospiza;

/// <summary>
/// Abstract class for Aerospiza (genus).
/// NCBI TaxId: 3390995
/// </summary>
public abstract class Aerospiza : Accipitridae, IAerospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aerospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3390995;

    /// <inheritdoc />
    public virtual string GenusName => "Aerospiza";

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
