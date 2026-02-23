using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Doboatherina;

/// <summary>
/// Abstract class for Doboatherina (genus).
/// NCBI TaxId: 2697003
/// </summary>
public abstract class Doboatherina : Atherinidae, IDoboatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doboatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2697003;

    /// <inheritdoc />
    public virtual string GenusName => "Doboatherina";

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
