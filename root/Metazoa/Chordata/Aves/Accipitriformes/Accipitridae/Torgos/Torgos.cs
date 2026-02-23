using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Torgos;

/// <summary>
/// Abstract class for Torgos (genus).
/// NCBI TaxId: 33605
/// </summary>
public abstract class Torgos : Accipitridae, ITorgos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Torgos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33605;

    /// <inheritdoc />
    public virtual string GenusName => "Torgos";

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
