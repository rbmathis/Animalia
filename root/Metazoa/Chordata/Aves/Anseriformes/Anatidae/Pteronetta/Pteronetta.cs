using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Pteronetta;

/// <summary>
/// Abstract class for Pteronetta (genus).
/// NCBI TaxId: 75876
/// </summary>
public abstract class Pteronetta : Anatidae, IPteronetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteronetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75876;

    /// <inheritdoc />
    public virtual string GenusName => "Pteronetta";

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
