using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Spizixos;

/// <summary>
/// Abstract class for Spizixos (genus).
/// NCBI TaxId: 241746
/// </summary>
public abstract class Spizixos : Pycnonotidae, ISpizixos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spizixos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241746;

    /// <inheritdoc />
    public virtual string GenusName => "Spizixos";

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
