using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Hymenolaimus;

/// <summary>
/// Abstract class for Hymenolaimus (genus).
/// NCBI TaxId: 337035
/// </summary>
public abstract class Hymenolaimus : Anatidae, IHymenolaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hymenolaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337035;

    /// <inheritdoc />
    public virtual string GenusName => "Hymenolaimus";

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
