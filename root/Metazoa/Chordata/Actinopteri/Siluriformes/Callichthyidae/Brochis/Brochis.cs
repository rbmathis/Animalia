using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Brochis;

/// <summary>
/// Abstract class for Brochis (genus).
/// NCBI TaxId: 245762
/// </summary>
public abstract class Brochis : Callichthyidae, IBrochis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brochis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245762;

    /// <inheritdoc />
    public virtual string GenusName => "Brochis";

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
