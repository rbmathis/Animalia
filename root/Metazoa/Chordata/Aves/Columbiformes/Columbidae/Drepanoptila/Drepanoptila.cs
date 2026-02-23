using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Drepanoptila;

/// <summary>
/// Abstract class for Drepanoptila (genus).
/// NCBI TaxId: 187112
/// </summary>
public abstract class Drepanoptila : Columbidae, IDrepanoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drepanoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187112;

    /// <inheritdoc />
    public virtual string GenusName => "Drepanoptila";

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
