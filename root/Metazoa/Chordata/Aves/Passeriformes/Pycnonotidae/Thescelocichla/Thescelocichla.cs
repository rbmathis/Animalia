using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Thescelocichla;

/// <summary>
/// Abstract class for Thescelocichla (genus).
/// NCBI TaxId: 374650
/// </summary>
public abstract class Thescelocichla : Pycnonotidae, IThescelocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thescelocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374650;

    /// <inheritdoc />
    public virtual string GenusName => "Thescelocichla";

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
