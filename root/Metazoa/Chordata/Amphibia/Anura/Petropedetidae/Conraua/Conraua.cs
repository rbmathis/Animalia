using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Conraua;

/// <summary>
/// Abstract class for Conraua (genus).
/// NCBI TaxId: 143457
/// </summary>
public abstract class Conraua : Petropedetidae, IConraua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conraua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143457;

    /// <inheritdoc />
    public virtual string GenusName => "Conraua";

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
