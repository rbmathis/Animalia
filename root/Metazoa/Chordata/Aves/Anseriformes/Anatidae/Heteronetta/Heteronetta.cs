using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Heteronetta;

/// <summary>
/// Abstract class for Heteronetta (genus).
/// NCBI TaxId: 555263
/// </summary>
public abstract class Heteronetta : Anatidae, IHeteronetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteronetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555263;

    /// <inheritdoc />
    public virtual string GenusName => "Heteronetta";

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
