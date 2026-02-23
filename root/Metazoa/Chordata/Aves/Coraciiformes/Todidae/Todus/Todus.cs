using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Todidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Todidae.Todus;

/// <summary>
/// Abstract class for Todus (genus).
/// NCBI TaxId: 57435
/// </summary>
public abstract class Todus : Todidae, ITodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Todus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57435;

    /// <inheritdoc />
    public virtual string GenusName => "Todus";

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
