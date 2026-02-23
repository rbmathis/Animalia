using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Tanganikallabes;

/// <summary>
/// Abstract class for Tanganikallabes (genus).
/// NCBI TaxId: 310916
/// </summary>
public abstract class Tanganikallabes : Clariidae, ITanganikallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tanganikallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310916;

    /// <inheritdoc />
    public virtual string GenusName => "Tanganikallabes";

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
