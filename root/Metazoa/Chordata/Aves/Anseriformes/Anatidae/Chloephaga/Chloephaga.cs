using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Chloephaga;

/// <summary>
/// Abstract class for Chloephaga (genus).
/// NCBI TaxId: 8859
/// </summary>
public abstract class Chloephaga : Anatidae, IChloephaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloephaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8859;

    /// <inheritdoc />
    public virtual string GenusName => "Chloephaga";

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
