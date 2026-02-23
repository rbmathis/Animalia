using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ponticola;

/// <summary>
/// Abstract class for Ponticola (genus).
/// NCBI TaxId: 637986
/// </summary>
public abstract class Ponticola : Gobiidae, IPonticola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ponticola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 637986;

    /// <inheritdoc />
    public virtual string GenusName => "Ponticola";

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
